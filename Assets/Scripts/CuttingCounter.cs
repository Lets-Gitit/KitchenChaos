using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingCounter : BaseCounter
{
    [SerializeField] private CuttingRecipeSO[] cuttingRecipeSOArray;


    public override void Interact(Player player) {
        // KitchenObject를 가지고 있지 않은 경우
        if (!HasKitchenObject()) {
            // 플레이어가 KitchenObject를 가지고 있는 경우
            if (player.HasKitchenObject()) {
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else {

            }
        }
        // KitchenObject를 가지고 있는 경우
        else {
            // 플레이어가 KitchenObject를 가지고 있는 경우
            if (player.HasKitchenObject()) {

            }
            // 플레이어가 KitchenObject를 가지고 있는 경우
            else {
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }
    
    public override void InteractAlternate(Player player) {
        if(HasKitchenObject()) {
            KitchenObjectSO outputKitchenSO = GetOutputForInput(GetKitchenObject().GetKitchenObjectSO());
            GetKitchenObject().DestroySelf();

            KitchenObject.SpawnKitchenObject(outputKitchenSO, this);
        }
    }

    private KitchenObjectSO GetOutputForInput(KitchenObjectSO inputKitchenObjectSO) {
        foreach (CuttingRecipeSO cuttingRecipeSO in cuttingRecipeSOArray) {
            if(cuttingRecipeSO.input == inputKitchenObjectSO) {
                return cuttingRecipeSO.output;
            }
        }
        return null;
    }
}

