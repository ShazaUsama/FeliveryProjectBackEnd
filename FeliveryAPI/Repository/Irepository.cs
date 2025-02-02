﻿namespace FeliveryAPI.Repository
{
    public interface IRepository<T>
    {
        public List<T> GetAll();
        public T? GetDetails(int id);
        public void Insert(T t);
        public void Update(T entity);
        public void Delete(int id);
    }
}
