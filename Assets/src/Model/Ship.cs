using UnityEngine;

public class Ship : MonoBehaviour
{
    #region Static and Constant Variables
    #endregion

    #region Private fields
    #endregion

    #region Public Variables

    /// <summary>
    /// boosters are used to calculate how many bonus spaces the ship can move each turn
    /// </summary>
    public int booster { get; set; }

    /// <summary>
    /// cannons are used in encounters typically the higher cannon value wins
    /// </summary>
    public int cannon { get; set; }

    /// <summary>
    /// freightpods are used to determine if you may enter an alien colony
    /// </summary>
    public int freightpods { get; set; }

    /// <summary>
    /// 2 fame medals = 1 point, sometimes gained/lossed in encounters
    /// </summary>
    public int famemedals { get; set; }

    #endregion

    /// <summary>
    /// Constructor
    /// </summary>
    public Ship()
    {
        booster = 0;
        cannon = 0;
        freightpods = 0;
        famemedals = 0;
    }
}
