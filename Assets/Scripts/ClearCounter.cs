using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter, IKitchenObjectParent
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public override void Interact(Player player) {
        // KitchenObject를 가지고 있지 않은 경우
        if (!HasKitchenObject()) {
            // 플레이어가 KitchenObject를 가지고 있는 경우
            if(player.HasKitchenObject()) {
                player.GetKitchenObject().SetKitchenObjectParent(this);
            } else {

            }
        }
        // KitchenObject를 가지고 있는 경우
        else {
            // 플레이어가 KitchenObject를 가지고 있는 경우
            if(player.HasKitchenObject()) {

            } 
            // 플레이어가 KitchenObject를 가지고 있는 경우
            else {
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }
}
