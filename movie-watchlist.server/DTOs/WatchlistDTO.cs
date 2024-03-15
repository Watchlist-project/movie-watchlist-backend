﻿using movie_watchlist.server.Models;

namespace movie_watchlist.server.DTOs
{
    public record struct WatchlistDTO
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }
        public List<int> MovieIDs { get; init; } = new List<int>();

        public WatchlistDTO(Watchlist watchlist)
        {
            Id = watchlist.Id;
            Name = watchlist.Name;
            Description = watchlist.Description;
            foreach (var movie in watchlist.Movies)
            {
                MovieIDs.Append(movie.Id);
            }
        }

        static public List<WatchlistDTO> ArrayOfWatchlistDTOs(List<Watchlist> watchlists)
        {
            var watchlistList = new List<WatchlistDTO>();
            foreach (var watchlist in watchlists)
            {
                watchlistList.Append(new WatchlistDTO(watchlist));
            }
            return watchlistList;
        }
    }
}