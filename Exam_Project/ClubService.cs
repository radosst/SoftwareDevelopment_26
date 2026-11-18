using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Project
{
    internal class ClubService
    {
        private readonly ClubRepository repository;
        private readonly ClubData data;

        public ClubService(ClubRepository repository)
        {
            this.repository = repository;
            this.data = this.repository.Load();
        }

        public Club FindById(int id)
        {
            foreach (var club in data.Clubs)
            {
                if (club.Id == id)
                {
                    return club;
                }

            }

            return null;
        }
        public void AddClub(string name, DateOnly date)
        {
            name=name?.Trim()?? string.Empty;

            if(name.Length<3)
            {
                throw new ArgumentException("Imeto trqbva da ima pone 3 simvola");
            }
            if(date<DateOnly.FromDateTime(DateTime.Today))
            {
                throw new ArgumentException("Datata ne moje da e v minaloto");
            }

           
            var club = new Club(data.NextId, name, date);
            data.Clubs.Add(club);
            data.NextId++;

            repository.Save(data);

        }

        public IReadOnlyList<Club> GetAllClubs()
        {
            return data.Clubs.AsReadOnly();
        }

        public void DeleteClub(int id)
        {
            Club clubToRemove = FindById(id);

            if(clubToRemove == null)
            {
                throw new ArgumentException($"Klub s id {id} ne sushtestvuva");
            }

            data.Clubs.Remove(clubToRemove);
            repository.Save(data);
        }

        public IReadOnlyList<Club> GetClubsByDate(DateOnly date)
        {
            List<Club> result = new List<Club>();

            foreach (var club in data.Clubs)
            {
                if (club.Date == date)
                {
                    result.Add(club);
                }
            }

            return result.AsReadOnly();
        }
    }

    internal class Club
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateOnly Date { get; set; }

        public Club() { }

        public Club(int id, string name, DateOnly date)
        {
            Id = id;
            Name = name;
            Date = date;
        }

    }

    
}

