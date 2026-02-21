using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    [System.Serializable]
    public class InventorySlot
    {
        public Button ButtonParent;
        public Image ImageChild;
        public Weapon WeaponInSlot;
    }
    public Sprite DefaultImage;
    public Image CurrentWeapon_Image;

    public InventorySlot[] InventorySlots = new InventorySlot[8];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < InventorySlots.Length; i++)
        {
            InventorySlot slot = InventorySlots[i];
            slot.ImageChild = slot.ButtonParent.GetComponentInChildren<Image>();

            int index = i;
            slot.ButtonParent.onClick.AddListener(() => OnSlotClicked(index));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TryToPickUpItem(GameObject PickUpPicked)
    {
        for(int i = 0; i < InventorySlots.Length;i++)
        {
            if(InventorySlots[i].ImageChild.sprite == DefaultImage)
            {
                InventorySlots[i].ImageChild.sprite = PickUpPicked.GetComponent<Pickup>().SourceImage;
                InventorySlots[i].WeaponInSlot = PickUpPicked.GetComponent<Pickup>().ItemInSOForm;
                break;
            }
        }
    }

    private void OnSlotClicked(int SlotIndex)
    {
        if (InventorySlots[SlotIndex].ImageChild.sprite != DefaultImage)
        {
            CurrentWeapon_Image.sprite = InventorySlots[SlotIndex].ImageChild.sprite;
            InventorySlots[SlotIndex].ImageChild.sprite = DefaultImage;
        }
    }
}