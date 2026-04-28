namespace DemoPlatform.Models
{
    public class PlatformData
    {
        public string AppName { get; set; }
        public string Version { get; set; }
        public string Environment { get; set; }
        public DateTime GeneratedAt { get; set; }
        public List<User> Users { get; set; }
        public List<Project> Projects { get; set; }
        public SystemConfig SystemConfig { get; set; }
        public List<Log> Logs { get; set; }
        public Metrics Metrics { get; set; }
        public Miscellaneous Misc { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastLogin { get; set; }
        public UserPreferences Preferences { get; set; }
        public List<string> Tags { get; set; }
        public Address Address { get; set; }
    }

    public class UserPreferences
    {
        public string Theme { get; set; }
        public string Language { get; set; }
        public NotificationSettings Notifications { get; set; }
    }

    public class NotificationSettings
    {
        public bool Email { get; set; }
        public bool Sms { get; set; }
        public bool Push { get; set; }
    }

    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
    }

    public class Project
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public decimal Budget { get; set; }
        public string Currency { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<int> Team { get; set; }
        public List<Milestone> Milestones { get; set; }
    }

    public class Milestone
    {
        public string Name { get; set; }
        public bool Completed { get; set; }
        public DateTime DueDate { get; set; }
    }

    public class SystemConfig
    {
        public ApiConfig Api { get; set; }
        public FeatureFlags Features { get; set; }
        public SystemLimits Limits { get; set; }
    }

    public class ApiConfig
    {
        public string BaseUrl { get; set; }
        public int TimeoutMs { get; set; }
        public int Retries { get; set; }
    }

    public class FeatureFlags
    {
        public bool EnableAI { get; set; }
        public bool EnableLogging { get; set; }
        public bool EnablePayments { get; set; }
    }

    public class SystemLimits
    {
        public int MaxUsers { get; set; }
        public int MaxProjects { get; set; }
        public int RateLimitPerMinute { get; set; }
    }

    public class Log
    {
        public string Id { get; set; }
        public string Level { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
        public LogMetadata Metadata { get; set; }
    }

    public class LogMetadata
    {
        public string Service { get; set; }
        public string Region { get; set; }
        public string ErrorCode { get; set; }
    }

    public class Metrics
    {
        public int ActiveUsers { get; set; }
        public int RequestsToday { get; set; }
        public double ErrorRate { get; set; }
        public double UptimePercentage { get; set; }
    }

    public class Miscellaneous
    {
        public string Notes { get; set; }
        public List<bool> Flags { get; set; }
        public List<object> RandomValues { get; set; }
    }
}
