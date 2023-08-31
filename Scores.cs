public class Scores{

        private string first_name;
        private string last_name;

        private int score;

        public Scores(string first_name, string last_name, int score){

            this.first_name = first_name;
            this.last_name = last_name;
            this.score = score;
        }


        public string Name{
            get{
                return first_name;
            }
            set{
                this.first_name = value;
            }
        }

         public string Last_Name{
            get{
                return last_name;
            }
            set{
                this.last_name = value;
            }
        }

        public int Score{
            get{
                return score;
            }

            set{
                this.score = value;
            }
        }



}