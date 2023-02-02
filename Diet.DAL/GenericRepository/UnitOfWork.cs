using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diet.DAL.Entities;
using Diet.Model;

namespace Diet.DAL.GenericRepository
{
    public interface IUnitOfWork
       : IDisposable
    {
    }

    public class UnitOfWork: IUnitOfWork
    {
        private DietAppContext _context = new DietAppContext();
        private Repository<User> _userRepository;
        private Repository<UserDetail> _userDetailRepository;
        private Repository<Food> _foodRepository;
        private Repository<Meal> _mealRepository;
        private Repository<MealFood> _mealFoodRepository;
        private Repository<Activity> _activityRepository;
        private Repository<UserActivity> _userActivityRepository;
        private Repository<UserBC> _userBcRepository;
        private bool _disposed = false;
        public Repository<User> UserRepository
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new Repository<User>(_context);
                return _userRepository;
            }
        }
        public Repository<UserDetail> UserDetailRepository
        {
            get
            {
                if (_userDetailRepository == null)
                    _userDetailRepository = new Repository<UserDetail>(_context);
                return _userDetailRepository;
            }
        }
        public Repository<Food> FoodRepository
        {
            get
            {
                if (_foodRepository == null)
                    _foodRepository = new Repository<Food>(_context);
                return _foodRepository;
            }
        }
        public Repository<Meal> MealRepository
        {
            get
            {
                if (_mealRepository == null)
                    _mealRepository = new Repository<Meal>(_context);
                return _mealRepository;
            }
        }
        public Repository<MealFood> MealFoodRepository
        {
            get
            {
                if (_mealFoodRepository == null)
                    _mealFoodRepository = new Repository<MealFood>(_context);
                return _mealFoodRepository;
            }
        }
        public Repository<Activity> ActivityRepository
        {
            get
            {
                if (_activityRepository == null)
                    _activityRepository = new Repository<Activity>(_context);
                return _activityRepository;
            }
        }
        public Repository<UserActivity> UserActivityRepository
        {
            get
            {
                if (_userActivityRepository == null)
                    _userActivityRepository = new Repository<UserActivity>(_context);
                return _userActivityRepository;
            }
        }
        public Repository<UserBC> UserBcRepository
        {
            get
            {
                if (_userBcRepository == null)
                    _userBcRepository = new Repository<UserBC>(_context);
                return _userBcRepository;
            }
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
