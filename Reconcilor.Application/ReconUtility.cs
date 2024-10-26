namespace Reconcilor.Application
{
    public class ReconUtility
    {

        public static decimal CalculateTotalGrade(decimal gradeValue, decimal tonnes)
        {
			try
			{
                return Math.Round((gradeValue / 100) * tonnes, 2);
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

        public static decimal CalculateDryTonnes(decimal WetTonnes, decimal Moisture)
        {
            try
            {
                return (WetTonnes - ((Moisture / 100) * WetTonnes));
            }
            catch (DivideByZeroException)
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
