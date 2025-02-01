using Robust.Shared.GameStates;
using Content.Shared.Inventory;

namespace Content.Shared._DV.Surgery;

/// <summary>
///     Raised on an entity when a surgery is about to be performed, in case a system wants to modify the speed, such as surgical gloves.
/// </summary>
public sealed class SurgerySpeedModifyEvent : EntityEventArgs, IInventoryRelayEvent
{
    public SlotFlags TargetSlots { get; } = ~SlotFlags.POCKET;
    public float Multiplier;
 
    public SurgerySpeedModifyEvent(float multiplier)
    {
        Multiplier = multiplier;
    }
}
