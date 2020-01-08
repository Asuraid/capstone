using UnityEngine;
using TeamMars.Capstone.Manager.Resources;

public class UseResources : MonoBehaviour
{
    public enum UsedResources // your custom enumeration
    {
        None,
        RawGame,
        RawFish,
        Wood,
    };
    [Header("Used Resources")]
    [Tooltip("What resource will be used from this area; can be multiple.")]
    public bool usingRawFish;
    public bool usingCookedFish;

    public bool usingRawMeat;
    public bool usingCookedMeat;

    public int usedAmount;

    [Header("Resource Output")]
    [Tooltip("What resource will be gained from this area; can be multiple.")]
    public bool hasAnOutput;

    public bool gainRawFish;
    public bool gainCookedFish;

    public bool gainRawMeat;
    public bool gainCookedMeat;

    public int gainedAmount;

    private void OnMouseDown()
    {
        print("do thing here");

    }
}
