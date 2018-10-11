using LibraryData;
using LibraryData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryServices
{
    public class CheckoutServices : ICheckout
    {
        private LibraryContext _context;

        public CheckoutServices(LibraryContext context)
        {
            _context = context;
        }
        public void Add(Checkout newCheckout)
        {
            _context.Add(newCheckout);
            _context.SaveChanges();
        }

        public void CheckInItem(int id)
        {
            var now = DateTime.Now;

            var item = _context.LibraryAssets.FirstOrDefault(a => a.Id == id);

            _context.Update(item);

            //remove any existing checkouts on the item
            RemoveExistingCheckouts(id);
            //close any existing checkout history
            CloseExistingCheckoutHistory(id, now);
            //Look for existing holds on the item
            var currentHolds = _context.Holds.Include(h => h.LibraryAsset).Include(h => h.LibraryCard).Where(h => h.LibraryAsset.Id == id);
            //If there are holds, checkout item to libraryCard with earliest hold
            if (currentHolds.Any())
            {
                CheckoutToEarliestHold(id, currentHolds);
                return;
            }
            //Otherwise, update the item status to available
            item.Status = _context.Statuses.FirstOrDefault(status => status.Name == "Available");

            _context.SaveChanges();

        }

        private void CheckoutToEarliestHold(int id, IQueryable<Hold> currentHolds)
        {
            var earliestHold = currentHolds.OrderBy(holds => holds.HoldPlaced).FirstOrDefault();

            var card = earliestHold.LibraryCard;

            _context.Remove(earliestHold);
            _context.SaveChanges(); //Remove earliest hold since it  is now longer needed when it's been checked out

            CheckoutItem(id, card.Id);

        }

        public void CheckoutItem(int id, int libraryCardId)
        {
            if (IsCheckedOut(id))
            {
                return;
                //Add logic here to handle feedback to the user;
            }

            var item = _context.LibraryAssets.FirstOrDefault(a => a.Id == id);
            _context.Update(item);

            item.Status = _context.Statuses.FirstOrDefault(status => status.Name == "Checked Out");

            var libraryCard = _context.LibraryCards.Include(card => card.Checkouts).FirstOrDefault(card => card.Id == libraryCardId);
            var now = DateTime.Now;

            var checkout = new Checkout
            {
                LibraryAsset = item,
                LibraryCard = libraryCard,
                Since = now,
                Until = GetDefaultCheckoutTime(now)

            };

            _context.Add(checkout);

            var checkoutHistory = new CheckoutHistory
            {
                CheckedOut = now,
                LibraryAsset = item,
                LibraryCard = libraryCard
            };
            _context.Add(checkoutHistory);

            _context.SaveChanges();
        }

        private DateTime GetDefaultCheckoutTime(DateTime now)
        {
            return now.AddDays(30);
        }

        public IEnumerable<Checkout> GetAll()
        {
            return _context.Checkouts;
        }

        public Checkout GetById(int checkoutId)
        {
            return GetAll().FirstOrDefault(c => c.Id == checkoutId);
        }

        public IEnumerable<CheckoutHistory> GetCheckoutHistory(int id)
        {
            return _context.CheckoutHistories.Include(h => h.LibraryAsset).Include(h => h.LibraryCard).Where(h => h.LibraryAsset.Id == id);
        }

        public string GetCurrentHoldPatron(int holdId)
        {
            var hold = _context.Holds.Include(h => h.LibraryAsset).Include(h => h.LibraryCard).FirstOrDefault(h => h.Id == holdId);

            var cardId = hold?.LibraryCard.Id; // ? is a null conditional operator  
          //handles null exception if card id is null

            var patron = _context.Patrons.Include(p => p.LibraryCard).FirstOrDefault(p => p.LibraryCard.Id == cardId);

            return patron?.FirstName + " " + patron?.LastName;
        }

        public DateTime GetCurrentHoldPlaced(int holdId)
        {
            return _context.Holds.Include(h => h.LibraryAsset).Include(h => h.LibraryCard).FirstOrDefault(h => h.Id == holdId).HoldPlaced;
        }

        public IEnumerable<Hold> GetCurrentHolds(int holdId)
        {
            return _context.Holds.Include(h => h.LibraryAsset).Where(h => h.LibraryAsset.Id == holdId);
        }

        public string GetCurrentCheckoutPatron(int assetId)
        {
            var checkout = GetCheckoutByAssetId(assetId);
           if (checkout == null)
            {
                return "";
            };

            var cardId = checkout.LibraryCard.Id;
            var patron = _context.Patrons.Include(p => p.LibraryCard).FirstOrDefault(p => p.LibraryCard.Id == cardId);

            return patron.FirstName + " " + patron.LastName;
        }

        private Checkout GetCheckoutByAssetId(int assetId)
        {
            return _context.Checkouts.Include(co => co.LibraryAsset).Include(co => co.LibraryCard).FirstOrDefault(co => co.LibraryAsset.Id == assetId);
        }

        public Checkout GetLatestCheckout(int id)
        {
            return _context.Checkouts.Where(c => c.LibraryAsset.Id == id).OrderByDescending(c => c.Since).FirstOrDefault();
        }

        public int GetNumberOfCopies(int id)
        {
            var item = _context.LibraryAssets.FirstOrDefault(a => a.Id == id);
            return item.NumberOfCopies;
        }

        public bool IsCheckedOut(int id)
        {
            var isCheckedOut = _context.Checkouts.Where(c => c.LibraryAsset.Id == id).Any();
            return isCheckedOut;
        }

        public void MarkFound(int id)
        {
            var now = DateTime.Now;
            var item = _context.LibraryAssets.FirstOrDefault(a => a.Id == id);

            _context.Update(item); //mark item for update

            item.Status = _context.Statuses.FirstOrDefault(status => status.Name == "Available");

            //remove any existing checkouts on the item
            RemoveExistingCheckouts(id);


            //close any existing checkout history
            CloseExistingCheckoutHistory(id, now);


            _context.SaveChanges();
        }

        private void CloseExistingCheckoutHistory(int assetId, DateTime now)
        {
            var history = _context.CheckoutHistories.FirstOrDefault(h => h.LibraryAsset.Id == assetId && h.CheckedIn == null);

            if (history != null)
            {
                _context.Update(history);
                history.CheckedIn = now;
            }
        }

        private void RemoveExistingCheckouts(int assetId)
        {

            var checkout = _context.Checkouts.FirstOrDefault(co => co.LibraryAsset.Id == assetId);

            if (checkout != null)
            {
                _context.Remove(checkout);
            }

        }


        public void MarkLost(int id)
        {
            var item = _context.LibraryAssets.FirstOrDefault(a => a.Id == id);

            _context.Update(item);

            item.Status = _context.Statuses.FirstOrDefault(status => status.Name == "Lost");

            _context.SaveChanges();
        }

        public void PlaceHold(int assetId, int libraryCardId)
        {
            var now = DateTime.Now;

            var asset = _context.LibraryAssets.Include(a => a.Status).FirstOrDefault(a => a.Id == assetId);
            _context.Update(asset);

            var card = _context.LibraryCards.FirstOrDefault(c => c.Id == libraryCardId);

            if (asset.Status.Name == "Available")
            {
                asset.Status = _context.Statuses.FirstOrDefault(status => status.Name == "On Hold");
            }

            var hold = new Hold
            {
                HoldPlaced = now,
                LibraryAsset = asset,
                LibraryCard = card
            };

            _context.Add(hold);
            _context.SaveChanges();
        }
    }
}
