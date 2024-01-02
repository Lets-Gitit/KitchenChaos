using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter, IKitchenObjectParent
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public override void Interact(Player player) {
        // KitchenObject�� ������ ���� ���� ���
        if (!HasKitchenObject()) {
            // �÷��̾ KitchenObject�� ������ �ִ� ���
            if(player.HasKitchenObject()) {
                player.GetKitchenObject().SetKitchenObjectParent(this);
            } else {

            }
        }
        // KitchenObject�� ������ �ִ� ���
        else {
            // �÷��̾ KitchenObject�� ������ �ִ� ���
            if(player.HasKitchenObject()) {

            } 
            // �÷��̾ KitchenObject�� ������ �ִ� ���
            else {
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }
}
