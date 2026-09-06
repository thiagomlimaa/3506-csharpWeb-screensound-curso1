using Microsoft.EntityFrameworkCore;

namespace ScreenSound.Modelos;

public class ScreenSoundContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
    }
}

