using angular_test_project.Models;
public class AppDbContextController
{
    private readonly AppDbContext _context;

    public AppDbContextController(AppDbContext context)
    {
        _context = context;
    }
}