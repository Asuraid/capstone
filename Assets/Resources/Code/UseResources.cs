using UnityEngine;
using TeamMars.Capstone.Manager.Resources;

public class UseResources : MonoBehaviour
{
    public enum GatheredResource // your custom enumeration
    {
        None,
        RawGame,
        RawFish,
        Wood,
    };
    [Header("Gathered Resource")]
    [Tooltip("What resource will be gathered from this area.")]
    public GatheredResource gatheredResource = GatheredResource.None;  // this public var should appear as a drop down

    public bool hasAnOutput;

    public int gatheredAmount;

    private void OnMouseDown()
    {
        switch (gatheredResource)
        {
            case GatheredResource.None:
                print("There are no resources to gather here.");
                break;
            case GatheredResource.RawGame:
                ResourceManager.Instance.AddRawGame(gatheredAmount);
                break;
            case GatheredResource.RawFish:
                ResourceManager.Instance.AddRawFish(gatheredAmount);
                break;
            default:
                print("Something went wrong to trigger a default state.");
                break;
        }

    }
}
