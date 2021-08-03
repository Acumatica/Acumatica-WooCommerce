using ACBC.Tests.Wrappers;

namespace ACSC.Tests.Extensions.SalesOrder
{
    public class SPSubstitutionList : SM206026_SYSubstitutionMaint
    {
        public c_substitution_form Form => Substitution_form;
        public c_substitutionvalues_grid Grid => SubstitutionValues_grid;
    }
}