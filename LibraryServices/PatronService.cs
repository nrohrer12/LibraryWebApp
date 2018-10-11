using LibraryData;
using LibraryData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryServices
{
    public class PatronService : IPatron
    {
        private LibraryContext _context;

        public PatronService(LibraryContext context)
        {
            _context = context;
        }
        public Patron Get(int id)
        {
            return GetAll().FirstOrDefault(p => p.Id == id);
        }

        public void Add(Patron newPatron)
        {
            _context.Add(newPatron);
            _context.SaveChanges();
        }

        public IEnumerable<Patron> GetAll()
        {
            return _context.Patrons.Include(p => p.LibraryCard).Include(p => p.HomeLibraryBranch);
        }

        public IEnumerable<CheckoutHistory> GetCheckoutHistory(int patronId)
        {
            //Gets patron with matches Id, then gets their library card Id
            var cardId = Get(patronId).LibraryCard.Id; 
                //_context.Patrons.Include(p => p.LibraryCard).FirstOrDefault(p => p.Id == patronId).LibraryCard.Id;

            return _context.CheckoutHistories.Include(co => co.LibraryCard).Include(co => co.LibraryAsset)
                .Where(co => co.LibraryCard.Id == cardId).OrderByDescending(co => co.CheckedOut);
        }

        public IEnumerable<Checkout> GetCheckouts(int patronId)
        {
            var cardId = Get(patronId).LibraryCard.Id;
            
               // _context.Patrons.Include(p => p.LibraryCard).FirstOrDefault(p => p.Id == patronId).LibraryCard.Id;

            return _context.Checkouts.Include(co => co.LibraryCard).Include(co => co.LibraryAsset).Where(co => co.LibraryCard.Id == cardId);
        }

        public IEnumerable<Hold> GetHolds(int patronId)
        {
            var cardId = Get(patronId).LibraryCard.Id;

            return _context.Holds.Include(h => h.LibraryCard).Include(h => h.LibraryAsset).Where(h => h.LibraryCard.Id == cardId).OrderByDescending(h => h.HoldPlaced);
        }
    }
}
