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
        string returnText = Container.GetHoverText();
        if (!Container.m_checkGuardStone || PrivateArea.CheckAccess(base.transform.position, 0f, flash: false))
        {
            bool gamepad = ZInput.IsNonClassicFunctionality() && ZInput.IsGamepadActive();
            string altKey = gamepad ? "$KEY_AltKeys" : "$KEY_AltPlace";
            returnText += Localization.instance.Localize($"\n[<color=yellow><b>{altKey} + $KEY_Use</b></color>] {AlternateInteract}");
        }

        return returnText;
    }

    public string GetHoverName()
    {
        return Localization.instance.Localize(Name);
    }

    public bool UseItem(Humanoid user, ItemDrop.ItemData item)
    {
        return false;
    }

    public float GetHoverOffset()
    {
        return 0f;
    }
}
