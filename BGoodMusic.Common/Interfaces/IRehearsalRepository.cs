using BGoodMusic.Models;
using System.Collections.Generic;

public interface IRehearsalRepository
{
    Rehearsal AddRehearsal(Rehearsal rehearsal);
    List<Rehearsal> GetRehearsals();
    int SaveChanges();
}