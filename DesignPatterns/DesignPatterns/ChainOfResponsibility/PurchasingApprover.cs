namespace DesignPatterns.ChainOfResponsibility
{
    public class PurchasingApprover : Approver
    {
        public override bool ApproveMaterial(Material material, ref string reason)
        {
            if(material.Budget < 10000)
            {
                return true;
            }
            else if (material.Budget < 100000)
            {
                if (NextApprover != null)
                {
                    return NextApprover.ApproveMaterial(material, ref reason);
                }
                return true;
            }
            else
            {
                reason = "This is way too much - find another way!";
                return false;
            }       
        }
    }
}
