using UnityEngine;

public class CustomInteract : MonoBehaviour, Hoverable, Interactable
{
    public Container container;
    public Sign sign;

    public void Awake()
    {
        container = GetComponent<Container>();
        sign = GetComponent<Sign>();
    }

    public bool Interact(Humanoid user, bool hold, bool alt)
    {
        if (alt)
        {
            return sign.Interact(user, hold, alt);
        }
        else
        {
            return container.Interact(user, hold, alt);
        }
    }

    public string GetHoverText()
    {
        return Localization.instance.Localize("$piece_mpwoodendrawer\n[<color=yellow><b>$KEY_Use</b></color>] $piece_drawer_open\n[<color=yellow><b>Shift $KEY_Use</b></color>] $piece_drawer_edit");
    }

    public string GetHoverName()
    {
        return Localization.instance.Localize("$piece_mpwoodendrawer");
    }

    public bool UseItem(Humanoid user, ItemDrop.ItemData item)
    {
        return false;
    }
}
