﻿using ASPCoreDapper.Models;
using System.Collections.Generic;

namespace ASPCoreDapper.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Add(T item);
        void Remove(int id);
        void Update(T item);
        T FindByID(int id);
        IEnumerable<T> FindAll();
    }
}
