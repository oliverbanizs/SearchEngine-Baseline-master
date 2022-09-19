namespace Common
{
    public static class Config
    {
        public static string DatabasePath { get; } = "/Users/oliverbanizs/Projects/Resources/database.db";
        public static string DataSourcePath { get; } = "/Users/oliverbanizs/Projects/Resources";
        public static int NumberOfFoldersToIndex { get; } = 1; // Use 0 or less for indexing all folders
    }
}