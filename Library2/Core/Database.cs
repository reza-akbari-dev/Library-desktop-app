using Core.Data;

namespace Core
{
    public static class Database
    {
        private static libraryContext _context = new libraryContext();
        public static libraryContext Context { get => _context; }

    }
}
