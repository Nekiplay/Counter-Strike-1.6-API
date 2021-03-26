# Counter-Strike-1.6-API
API for Counter Strike 1.6
```C#
/* Creating API */
Counter_Strike_1_6_API api = new Counter_Strike_1_6_API();

/* LocalPlayer Information */
int PlayerHealth = api.Game.LocalPlayer.Health;
int PlayerArmor = api.Game.LocalPlayer.Armor;
int PlayerMoney = api.Game.LocalPlayer.Money;

/* Weapons Ammo */
int AWPAmmo = api.Game.LocalPlayer.Weapons.AWP.Ammo;
int AK47Ammo = api.Game.LocalPlayer.Weapons.AK47.Ammo;
int M4A4Ammo = api.Game.LocalPlayer.Weapons.M4A4.Ammo;
int DesertEagleAmmo = api.Game.LocalPlayer.Weapons.DesertEagle.Ammo;
int USPAmmo = api.Game.LocalPlayer.Weapons.USP.Ammo;
int GlockAmmo = api.Game.LocalPlayer.Weapons.Glock.Ammo;

/* Weapons IsReload */
bool AWPIsReload = api.Game.LocalPlayer.Weapons.AWP.Reload;
bool AK47IsReload = api.Game.LocalPlayer.Weapons.AK47.Reload;
bool M4A4IsReload = api.Game.LocalPlayer.Weapons.M4A4.Reload;
bool DesertEagleIsReload = api.Game.LocalPlayer.Weapons.DesertEagle.Reload;
bool USPIsReload = api.Game.LocalPlayer.Weapons.USP.Reload;
bool GlocksReload = api.Game.LocalPlayer.Weapons.USP.Reload;

/* Weapons IsSilencer */
bool M4A4IsSilencer = api.Game.LocalPlayer.Weapons.M4A4.Silencer;
bool USPIsSilencer  = api.Game.LocalPlayer.Weapons.USP.Silencer;
```
