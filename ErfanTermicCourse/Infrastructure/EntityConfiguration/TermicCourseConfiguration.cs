using ErfanTermicCourse.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ErfanTermicCourse.Infrastructure.EntityConfiguration;

public class TermicCourseConfiguration : IEntityTypeConfiguration<TermicCourses>
{
	public void Configure(EntityTypeBuilder<TermicCourses> builder)
	{
		builder.ToTable("TermicCourses", "TermicCourse");
		builder.HasKey(x => x.Id);
	}
}