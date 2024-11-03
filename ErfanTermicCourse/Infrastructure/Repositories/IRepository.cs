using ErfanTermicCourse.Infrastructure.Entities;

namespace ErfanTermicCourse.Infrastructure.Repositories;

public interface IRepository<TEntity> where TEntity : BaseEntity
{
	void Add(TEntity entity);
	Task AddAsync(TEntity entity);
	void AddRange(List<TEntity> entities);
	Task AddRangeAsync(List<TEntity> entities);
	void Update(TEntity entity);
	Task UpdateAsync(TEntity entity);
	void Delete(TEntity entity);
	Task DeleteAsync(TEntity entity);
	void SoftDelete(TEntity entity);
	TEntity GetById(long id);
	Task<TEntity> GetByIdAsync(long id);
	List<TEntity> GetAll();
	Task<List<TEntity>> GetAllAsync();

}
