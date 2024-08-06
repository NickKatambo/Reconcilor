namespace Reconcilor.Application
{
    public class ReconUtility
    {

        public static decimal CalculateContaintedGrade(decimal gradeValue, decimal tonnes)
        {
			try
			{
                return (gradeValue / tonnes) * 100;
            }
            catch(DivideByZeroException)
            {
                throw;
            }
			catch (Exception)
			{
				throw;
			}
        }
    }
}
