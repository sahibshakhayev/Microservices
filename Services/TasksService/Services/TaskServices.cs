using Microsoft.EntityFrameworkCore;
using TasksService.Data.Context;
using TasksService.Data.Model;

namespace TasksService.Services
{
    public class TaskServices
    {
        private readonly TaskDbContext _context;

        public TaskServices(TaskDbContext context)
        {
            _context = context;
        }

        public async Task<UserTask> AddTaskAsync(UserTask task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
            return task;
        }


        public async Task<bool> DeleteTaskAsync(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task == null)
            {
                return false;
            }

            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> UpdateTaskAsync(Task task)
        {
            _context.Entry(task).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }




    }
}
