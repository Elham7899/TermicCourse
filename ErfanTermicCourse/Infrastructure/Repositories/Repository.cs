using ErfanTermicCourse.Infrastructure.DbContexts;
using ErfanTermicCourse.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace ErfanTermicCourse.Infrastructure.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
	public Repository(ErfanDbContext dbContext)
	{
		this._dbContext = dbContext;
	}

	protected readonly ErfanDbContext _dbContext;

	public DbSet<TEntity> Entities { get; }

	public IQueryable<TEntity> Query => Entities;
	public IQueryable<TEntity> QueryAsNoTracking => Entities.AsNoTracking();

	public void Add(TEntity entity)
	{
		Entities.Add(entity);
		_dbContext.SaveChanges();
	}

	public async Task AddAsync(TEntity entity)
	{
		await Entities.AddAsync(entity);
		await _dbContext.SaveChangesAsync();
	}

	public void AddRange(List<TEntity> entities)
	{
		Entities.AddRange(entities);
		_dbContext.SaveChanges();
	}

	public async Task AddRangeAsync(List<TEntity> entities)
	{
		await Entities.AddRangeAsync(entities);
		await _dbContext.SaveChangesAsync();
	}

	public void Update(TEntity entity)
	{
		//todo
		Entities.Update(entity);
		_dbContext.SaveChanges();
	}

	public async Task UpdateAsync(TEntity entity)
	{
		//todo
		Entities.Update(entity);
		await _dbContext.SaveChangesAsync();
	}

	public void Delete(TEntity entity)
	{
		Entities.Remove(entity);
		_dbContext.SaveChanges();
	}

	public async Task DeleteAsync(TEntity entity)
	{
		Entities.Remove(entity);
		await _dbContext.SaveChangesAsync();
	}

	public void SoftDelete(TEntity entity)
	{
		entity.IsDeleted = true;
		Entities.Update(entity);
		_dbContext.SaveChanges();
	}

	public TEntity GetById(long id) => Entities.FirstOrDefault(x => x.Id == id);

	public Task<TEntity> GetByIdAsync(long id) => Entities.FirstOrDefaultAsync(x => x.Id == id);

	public List<TEntity> GetAll() => Entities.ToList();

	public Task<List<TEntity>> GetAllAsync() => Entities.ToListAsync();
}
