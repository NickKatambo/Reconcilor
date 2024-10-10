namespace Reconcilor.Application
{
    public class ReconUtility
    {

        public static decimal CalculateTotalGrade(decimal gradeValue, decimal tonnes)
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

        public static decimal CalculateDryTonnes(decimal WetTonnes, decimal Moisture)
        {
            try
            {
                return (WetTonnes -(WetTonnes - (Moisture / 100) * WetTonnes));
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
