using Fitness.BL.Model;
using System;
namespace Fitness.BL.Controller
{
    [Serializable]
    public class ExerciseController : ControllerBase
    {
        private readonly User user;
        public List<Exercise> Exercises { get; }

        public List<Activity> Activities { get; }

        private const string exercisesPath = "exercise.dat";

        private const string activitiesPath = "activities.dat";

        public ExerciseController(User user)
        {
            this.user = user ?? throw new ArgumentNullException(nameof(user));

            Exercises = GetAllExercises();

            Activities = GetAllActivities();
        }

        private List<Activity>? GetAllActivities()
        {
            return Load<List<Activity>>(activitiesPath) ?? new List<Activity>();
        }

        public void Add(Activity activity,
                        DateTime begin,
                        DateTime end)
        {
            var act = Activities.SingleOrDefault(a => a.Name == activity.Name);

            if (act == null)
            {
                Activities.Add(activity);

                var exercise = new Exercise(begin, end, activity, user);
                Exercises.Add(exercise);
            }
            else
            {
                var exercise = new Exercise(begin, end, act, user);
                Exercises.Add(exercise);
            }

            Save();
        }

        private List<Exercise>? GetAllExercises()
        {
            return Load<List<Exercise>>(exercisesPath) ?? new List<Exercise>();
        }

        private void Save()
        {
            Save(exercisesPath, Exercises);
            Save(activitiesPath, Activities);
        }
    }
}
