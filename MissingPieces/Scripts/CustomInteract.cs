using UnityEngine;

public class CustomInteract : MonoBehaviour, Hoverable, Interactable
{
    public string Name = "";
    public string DefaultInteract = "";
    public string AlternateInteract = "";
    public Container Container;
    public Sign Sign;

    public void Awake()
    {
        if (Container == null)
        {
            Container = GetComponent<Container>();
        }

        if (Sign == null)
        {
            Sign = GetComponent<Sign>();
        }
    }

    public bool Interact(Humanoid user, bool hold, bool alt)
    {
        if (alt)
        {
            return Sign.Interact(user, hold, alt);
        }
        else
        {
            return Container.Interact(user, hold, alt);
        }
    }

    public string GetHoverText()
    {
        return Localization.instance.Localize($"{Name}\n[<color=yellow><b>$KEY_Use</b></color>] {DefaultInteract}\n[<color=yellow><b>Shift $KEY_Use</b></color>] {AlternateInteract}");
    }

    public string GetHoverName()
    {
        return Localization.instance.Localize(Name);
    }

    public bool UseItem(Humanoid user, ItemDrop.ItemData item)
    {
        return false;
    }
}
