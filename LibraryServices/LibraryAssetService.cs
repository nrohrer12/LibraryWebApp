﻿using LibraryData;
using LibraryData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryServices
{
    public class LibraryAssetService : ILibraryAsset
    {
        private LibraryContext _context;

        public LibraryAssetService(LibraryContext context)
        {
            _context = context;
        }
        public void Add(LibraryAsset newAsset)
        {
            _context.Add(newAsset);
            _context.SaveChanges(); //commit changes to database
        }

        public IEnumerable<LibraryAsset> GetAll()
        {
            return _context.LibraryAssets.Include(asset => asset.Status).Include(asset => asset.Location);
        }

        public string GetAuthorOrDirector(int id)
        {
            var isBook = _context.LibraryAssets.OfType<Book>().Where(b => b.Id == id).Any();

            //var isVideo = _context.LibraryAssets.OfType<Book>().Where(b => b.Id == id).Any();
            //If a book, return author, if a video, return director, if neither, return unknown
            return isBook ? _context.Books.FirstOrDefault(b => b.Id == id).Author : _context.Videos.FirstOrDefault(v => v.Id == id).Director ?? "Unknown";
            

        }

        public LibraryAsset GetById(int id)
        {
            return _context.LibraryAssets.Include(asset => asset.Status).Include(asset => asset.Location).FirstOrDefault(asset => asset.Id == id);
        }

        public LibraryBranch GetCurrentLocation(int id)
        {
            return _context.LibraryAssets.FirstOrDefault(b => b.Id == id).Location;
            // return GetById(id).Location
        }

        public string GetDeweyIndex(int id)
        {
            if (_context.Books.Any(b => b.Id == id))
            {
                return _context.Books.FirstOrDefault(b => b.Id == id).DeweyIndex;
            }
            //var isBook = _context.LibraryAssets.OfType<Book>().Where(a => a.Id == id).DeweyIndex;
            else
                return "";
        }

        public string GetIsbn(int id)
        {
            if (_context.Books.Any(b => b.Id == id))
            {
                return _context.Books.FirstOrDefault(b => b.Id == id).ISBN;
            }
            else
                return "";
        }

        public string GetTitle(int id)
        {
            return _context.LibraryAssets.FirstOrDefault(a => a.Id == id).Title;
        }

        public string GetType(int id)
        {
            var book = _context.LibraryAssets.OfType<Book>().Where(b => b.Id == id);

            return book.Any() ? "Book" : "Video";
        }
    }
}
