namespace Determine_offspring_sex_based_on_genes_XX_and_XY_chromosomes
{
    public class Chromosome
    {
        public static string ChromosomeCheck(string sperm)
        {
            if (sperm == "XY")
            {
                return "Congratulations! You're going to have a son.";
            }
            return "Congratulations! You're going to have a daughter.";
        }
    }
}