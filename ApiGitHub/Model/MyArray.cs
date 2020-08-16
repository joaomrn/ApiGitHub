using System;

namespace ApiGitHub.Model
{
    public class MyArray
    {
        public int Id { get; set; }
        public string Node_id { get; set; }
        public string Name { get; set; }
        public string Full_name { get; set; }
        public Owner Owner { get; set; }

        public string Description { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Cpdated_at { get; set; }
        public DateTime Pushed_at { get; set; }
        public string Git_url { get; set; }
        public string Ssh_url { get; set; }
        public string Clone_url { get; set; }
        public string Svn_url { get; set; }
        public string Homepage { get; set; }
        public int Size { get; set; }
        public int Stargazers_count { get; set; }
        public int Watchers_count { get; set; }
        public string Language { get; set; }
    }
}
