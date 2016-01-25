using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Model;
using Library.Storage;

namespace Library.Services
{
    public class BookGenreService : IBookGenreService
    {
        private readonly IBookGenreRepository _genresRepository;

        public BookGenreService(IBookGenreRepository genresRepository)
        {
            _genresRepository = genresRepository;
        }

        public BookGenre Add(BookGenre genre)
        {
            if (genre.Genre == null)
            {
                throw new ArgumentException("The genre has to have all informations.");
            }

            var genreDb = _genresRepository.Persist(genre);
            if (genreDb != null && genreDb.Id.HasValue)
            {
                return Get(genreDb.Id.Value);
            }

            return null;
        }

        public void Remove(BookGenre genre)
        {
            _genresRepository.Remove(genre);
        }

        public void Update(BookGenre genre)
        {
            _genresRepository.Persist(genre);
        }

        public BookGenre Get(int id)
        {
            return _genresRepository.GetBookGenreById(id);
        }

        public IEnumerable<BookGenre> GetAllGenres()
        {
            return _genresRepository.GetAll();
        }




    }
}
