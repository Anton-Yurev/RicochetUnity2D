
using UnityEngine;

public class BonusOne : AbstractBonus
{

    public override void Go(Player platformMove)
    {
        platformMove.UpSpeed();
        platformMove.UpHealth();
    }
}
