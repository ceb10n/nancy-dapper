using System.Collections.Generic;
using nancy_dapper.App.Model;
using nancy_dapper.App.Repository;

namespace nancy_dapper.App.Service
{
    public class MusicService
    {
        private readonly MusicRepository repository;

        public MusicService(MusicRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Music> All()
        {
            return repository.All();
        }
    }
}