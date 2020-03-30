using System;
using System.Linq;
using System.Reflection;

namespace Learning.Whiteboard.Excercise
{
    public class Entry
    {
        public void Run(params string[] args)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();
            try
            {
                foreach (var arg in args)
                {
                    if (string.IsNullOrWhiteSpace(arg))
                    {
                        throw new ArgumentNullException("Invalid Argument");
                    }
                    else
                    {
                        Type whiteboardType = types.Where(type => type.GetInterfaces().Any(i => i == typeof(IExcercise))
                        && arg.Equals(type.Name, StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();

                        if (whiteboardType == null)
                        {
                            throw new Exception("Invalid excercise name or argument.");
                        }
                        else
                        {
                            IExcercise currentWhiteboard = (IExcercise)Activator.CreateInstance(whiteboardType);
                            currentWhiteboard.Start();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Exception in running a whiteboard", ex);
            }
        }
    }
}
