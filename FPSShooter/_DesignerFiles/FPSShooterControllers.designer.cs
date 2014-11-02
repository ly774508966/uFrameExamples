// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UniRx;
using UnityEngine;


public abstract class FPSDamageableControllerBase : Controller {
    
    [Inject("FPSGame")] public FPSGameViewModel FPSGame { get; set; }
    [Inject("LocalPlayer")] public FPSPlayerViewModel LocalPlayer { get; set; }
    [Inject("FPSMenu")] public FPSMenuViewModel FPSMenu { get; set; }
    public abstract void InitializeFPSDamageable(FPSDamageableViewModel fPSDamageable);
    
    public virtual FPSDamageableViewModel CreateFPSDamageable() {
        return ((FPSDamageableViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeFPSDamageable(((FPSDamageableViewModel)(viewModel)));
    }
    
    public virtual void ApplyDamage(FPSDamageableViewModel fPSDamageable, Int32 arg) {
    }
}

public abstract class FPSEnemyControllerBase : FPSDamageableController {
    
    [Inject] public FPSGameController FPSGameController {get;set;}
    public abstract void InitializeFPSEnemy(FPSEnemyViewModel fPSEnemy);
    
    public override ViewModel CreateEmpty() {
        return new FPSEnemyViewModel(this);
    }
    
    public virtual FPSEnemyViewModel CreateFPSEnemy() {
        return ((FPSEnemyViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializeFPSEnemy(((FPSEnemyViewModel)(viewModel)));
    }
}

public abstract class FPSGameControllerBase : Controller {
    
    [Inject("FPSGame")] public FPSGameViewModel FPSGame { get; set; }
    [Inject("LocalPlayer")] public FPSPlayerViewModel LocalPlayer { get; set; }
    [Inject("FPSMenu")] public FPSMenuViewModel FPSMenu { get; set; }
    [Inject] public FPSPlayerController FPSPlayerController {get;set;}
    [Inject] public FPSEnemyController FPSEnemyController {get;set;}
    public abstract void InitializeFPSGame(FPSGameViewModel fPSGame);
    
    public override ViewModel CreateEmpty() {
        return new FPSGameViewModel(this);
    }
    
    public virtual FPSGameViewModel CreateFPSGame() {
        return ((FPSGameViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeFPSGame(((FPSGameViewModel)(viewModel)));
    }
    
    public virtual void MainMenu(FPSGameViewModel fPSGame) {
    }
    
    public virtual void QuitGame(FPSGameViewModel fPSGame) {
    }
}

public abstract class FPSPlayerControllerBase : FPSDamageableController {
    
    [Inject] public FPSGameController FPSGameController {get;set;}
    [Inject] public FPSWeaponController FPSWeaponController {get;set;}
    public abstract void InitializeFPSPlayer(FPSPlayerViewModel fPSPlayer);
    
    public override ViewModel CreateEmpty() {
        return new FPSPlayerViewModel(this);
    }
    
    public virtual FPSPlayerViewModel CreateFPSPlayer() {
        return ((FPSPlayerViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializeFPSPlayer(((FPSPlayerViewModel)(viewModel)));
    }
    
    public virtual void NextWeapon(FPSPlayerViewModel fPSPlayer) {
    }
    
    public virtual void PickupWeapon(FPSPlayerViewModel fPSPlayer, FPSWeaponViewModel arg) {
    }
    
    public virtual void PreviousWeapon(FPSPlayerViewModel fPSPlayer) {
    }
    
    public virtual void SelectWeapon(FPSPlayerViewModel fPSPlayer, Int32 arg) {
    }
}

public abstract class FPSWeaponControllerBase : Controller {
    
    [Inject("FPSGame")] public FPSGameViewModel FPSGame { get; set; }
    [Inject("LocalPlayer")] public FPSPlayerViewModel LocalPlayer { get; set; }
    [Inject("FPSMenu")] public FPSMenuViewModel FPSMenu { get; set; }
    [Inject] public FPSPlayerController FPSPlayerController {get;set;}
    public abstract void InitializeFPSWeapon(FPSWeaponViewModel fPSWeapon);
    
    public override ViewModel CreateEmpty() {
        return new FPSWeaponViewModel(this);
    }
    
    public virtual FPSWeaponViewModel CreateFPSWeapon() {
        return ((FPSWeaponViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeFPSWeapon(((FPSWeaponViewModel)(viewModel)));
    }
    
    public virtual void BeginFire(FPSWeaponViewModel fPSWeapon) {
    }
    
    public virtual void NextZoom(FPSWeaponViewModel fPSWeapon) {
    }
    
    public virtual void EndFire(FPSWeaponViewModel fPSWeapon) {
    }
    
    public virtual void Reload(FPSWeaponViewModel fPSWeapon) {
    }
    
    public virtual void BulletFired(FPSWeaponViewModel fPSWeapon) {
    }
    
    public virtual void FinishedReloading(FPSWeaponViewModel fPSWeapon) {
    }
}

public abstract class WavesFPSGameControllerBase : FPSGameController {
    
    public abstract void InitializeWavesFPSGame(WavesFPSGameViewModel wavesFPSGame);
    
    public override ViewModel CreateEmpty() {
        return new WavesFPSGameViewModel(this);
    }
    
    public virtual WavesFPSGameViewModel CreateWavesFPSGame() {
        return ((WavesFPSGameViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        base.Initialize(viewModel);
        this.InitializeWavesFPSGame(((WavesFPSGameViewModel)(viewModel)));
    }
    
    public virtual void PlayerDied(WavesFPSGameViewModel wavesFPSGame) {
    }
    
    public virtual void Retry(WavesFPSGameViewModel wavesFPSGame) {
    }
    
    public virtual void NextWaveReady(WavesFPSGameViewModel wavesFPSGame) {
    }
    
    public virtual void Spawn(WavesFPSGameViewModel wavesFPSGame) {
    }
}

public abstract class FPSMenuControllerBase : Controller {
    
    [Inject("FPSGame")] public FPSGameViewModel FPSGame { get; set; }
    [Inject("LocalPlayer")] public FPSPlayerViewModel LocalPlayer { get; set; }
    [Inject("FPSMenu")] public FPSMenuViewModel FPSMenu { get; set; }
    public abstract void InitializeFPSMenu(FPSMenuViewModel fPSMenu);
    
    public override ViewModel CreateEmpty() {
        return new FPSMenuViewModel(this);
    }
    
    public virtual FPSMenuViewModel CreateFPSMenu() {
        return ((FPSMenuViewModel)(this.Create()));
    }
    
    public override void Initialize(ViewModel viewModel) {
        this.InitializeFPSMenu(((FPSMenuViewModel)(viewModel)));
    }
    
    public virtual void Play(FPSMenuViewModel fPSMenu) {
    }
}
