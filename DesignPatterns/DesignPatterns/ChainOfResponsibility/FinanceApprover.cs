namespace DesignPatterns.ChainOfResponsibility
{
    public class FinanceApprover : Approver
    {
        public override bool ApproveMaterial(Material material, ref string reason)
        {
            if (material.Budget < 100000)
            {
                if (NextApprover != null)
                {
                    NextApprover.ApproveMaterial(material, ref reason);
                }
                return true;
            }
            else
            {
                reason = "No bugdet!";
                return false;
            }
        }
    }
}
