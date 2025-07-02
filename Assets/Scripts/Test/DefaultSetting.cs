using UnityEngine;
using UnityEngine.InputSystem;

public class DefaultSetting : TestBase
{
    private void Start()
    {
        Factory.Instance.MakeItem(ItemCode.IronSword, new Vector3(2, 0, 0));
        Factory.Instance.MakeItem(ItemCode.RoundShield, new Vector3(-2, 0, 0));

        Factory.Instance.MakeItem(ItemCode.Apple, new Vector3(-20, 0, 1));
        Factory.Instance.MakeItem(ItemCode.HealingPotion, new Vector3(-20, 0, 3));

        Factory.Instance.MakeItem(ItemCode.Emerald, new Vector3(0, 0, 20), true);
        Factory.Instance.MakeItem(ItemCode.Emerald, new Vector3(0, 0, 20), true);
        Factory.Instance.MakeItem(ItemCode.Emerald, new Vector3(0, 0, 20), true);
        Factory.Instance.MakeItem(ItemCode.Emerald, new Vector3(0, 0, 20), true);
        Factory.Instance.MakeItem(ItemCode.Ruby, new Vector3(0, 0, 20), true);
        Factory.Instance.MakeItem(ItemCode.Ruby, new Vector3(0, 0, 20), true);
        Factory.Instance.MakeItem(ItemCode.Ruby, new Vector3(0, 0, 20), true);
        Factory.Instance.MakeItem(ItemCode.Ruby, new Vector3(0, 0, 20), true);
        Factory.Instance.MakeItem(ItemCode.Ruby, new Vector3(0, 0, 20), true);
    }

    protected override void OnTest1(InputAction.CallbackContext context)
    {
        Enemy[] enemies = FindObjectsByType<Enemy>(FindObjectsSortMode.None);
        foreach (Enemy enemy in enemies)
        {
            enemy.Die();
        }
    }
}
