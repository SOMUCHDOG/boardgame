using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Player Model
/// </summary>
public class Player : MonoBehaviour
{
    #region static and const variables
    #endregion

    #region Private Fields
    private Dictionary<string, ushort> inventory { get; set; }
    private string playername { get; set; }
    private Ship ship { get; set; }
    private int score { get; set; }
    private Dictionary<Resource, ushort> resources { get; set; }
    #endregion

    #region Public Fields

    #endregion

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name"></param>
    public Player(string name)
    {
        inventory = new Dictionary<string, ushort>
        {
            {"Colonies", 9 },
            {"Trade Stations", 7 },
            {"Transport Ships", 3 },
            {"Shipyards", 3 },
            {"Victory Point Marker", 1 },
        };

        playername = name;
        ship = new Ship();
        score = 0;
        resources = new Dictionary<Resource, ushort>
        {
            { Resource.ore, 0 },
            { Resource.fuel, 0 },
            { Resource.carbon, 0 },
            { Resource.food, 0 },
            { Resource.goods, 0 }
        };

    }

}