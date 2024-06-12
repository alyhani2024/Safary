﻿using Domain.Consts;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Domain.Repositories
{
	public interface IBaseRepository<T> where T : class
	{
		Task<IEnumerable<T>> GetAll(bool withNoTracking = true);
		IQueryable<T> GetQueryable();
		Task<T?> GetById(int id);
		Task<T?> Find(Expression<Func<T, bool>> predicate);
		Task<T?> Find(Expression<Func<T, bool>> predicate, string[]? includes = null);
		Task<T?> Find(Expression<Func<T, bool>> predicate,
				Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null);
        IQueryable<T> FilterFindAll(Expression<Func<T, bool>> predicate,
                         Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
                         Expression<Func<T, object>>? orderBy = null,
                         string? orderByDirection = OrderBy.Ascending);
        Task<IEnumerable<T>> FindAll(Expression<Func<T, bool>> predicate, int? skip = null, int? take = null,
			Expression<Func<T, object>>? orderBy = null, string? orderByDirection = OrderBy.Ascending);
		Task<IEnumerable<T>> FindAll(Expression<Func<T, bool>> predicate,
			Expression<Func<T, object>>? orderBy = null, string? orderByDirection = OrderBy.Ascending);
		Task<IEnumerable<T>> FindAll(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
			Expression<Func<T, object>>? orderBy = null, string? orderByDirection = OrderBy.Ascending);
		Task<T> Add(T entity);
		Task<IEnumerable<T>> AddRange(IEnumerable<T> entities);
		void Update(T entity);
		void Remove(T entity);
		void RemoveRange(IEnumerable<T> entities);
		void DeleteBulk(Expression<Func<T, bool>> predicate);
		bool IsExists(Expression<Func<T, bool>> predicate);
		int Count();
		int Count(Expression<Func<T, bool>> predicate);
		int Max(Expression<Func<T, bool>> predicate, Expression<Func<T, int>> field);
	}
}
