// create a class Repository
public record class Repository{
        public string Name { get; set; }
        public string Description { get; set; }
        
        // constructor
        public Repository(string name, string description) {
            Name = name;
            Description = description;
        }

    }