using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA;
using GTA.Native;
using GTA.Math;


namespace AmmoMod
{
    public class AmmoMod : Script
    {






        public AmmoMod()
        {

            this.Tick += new EventHandler(this.OnTick);



        }



        private void OnTick(object sender, EventArgs e)
        {
            if (Game.Player.Character.Weapons.Current.Group == WeaponGroup.AssaultRifle)
            {

                if (GTAExpansion.InventoryBag.doesPedHasInventoryBag(Game.Player.Character))
                {
                    if (Game.Player.Character.Armor == 0 && Game.Player.Character.Weapons.Current.Ammo > 210)
                    {

                        Function.Call<int>(Hash.SET_PED_AMMO, (InputArgument)Game.Player.Character, (InputArgument)Game.Player.Character.Weapons.Current.Hash, (InputArgument)210, (InputArgument)true);


                    }
                    else if (Game.Player.Character.Armor > 0 && Game.Player.Character.Weapons.Current.Ammo > 300)
                    {
                        Function.Call<int>(Hash.SET_PED_AMMO, (InputArgument)Game.Player.Character, (InputArgument)Game.Player.Character.Weapons.Current.Hash, (InputArgument)300, (InputArgument)true);

                    }
                }
                else if (!GTAExpansion.InventoryBag.doesPedHasInventoryBag(Game.Player.Character))
                {



                    if (Game.Player.Character.Armor == 0 && Game.Player.Character.Weapons.Current.Ammo > 120)
                    {
                        Function.Call<int>(Hash.SET_PED_AMMO, (InputArgument)Game.Player.Character, (InputArgument)Game.Player.Character.Weapons.Current.Hash, (InputArgument)120, (InputArgument)true);

                    }
                    else if (Game.Player.Character.Armor > 0 && Game.Player.Character.Weapons.Current.Ammo > 210)
                    {
                        Function.Call(Hash.ATTACH_ENTITY_TO_ENTITY, new InputArgument[15]
                        {
              (InputArgument) (Entity) Game.Player.Character.Weapons.
              (InputArgument) (Entity) Game.Player.Character,
              (InputArgument) Bone.SkelSpine3,
              (InputArgument) 0.075f,
              (InputArgument) 0.235f,
              (InputArgument)(-0.02f),
              (InputArgument) 0.0f,
              (InputArgument) 155f,
              (InputArgument) 0.0f,
              (InputArgument) true,
              (InputArgument) true,
              (InputArgument) false,
              (InputArgument) true,
              (InputArgument) 2,
              (InputArgument) true
                        });


                        Function.Call<int>(Hash.SET_PED_AMMO, (InputArgument)Game.Player.Character, (InputArgument)Game.Player.Character.Weapons.Current.Hash, (InputArgument)210, (InputArgument)true);

                    }
                }
            }
            else if (Game.Player.Character.Weapons.Current.Group == WeaponGroup.Pistol)
            {

                if (GTAExpansion.InventoryBag.doesPedHasInventoryBag(Game.Player.Character))
                {
                    if (Game.Player.Character.Armor == 0 && Game.Player.Character.Weapons.Current.Ammo > 96)
                    {

                        Function.Call<int>(Hash.SET_PED_AMMO, (InputArgument)Game.Player.Character, (InputArgument)Game.Player.Character.Weapons.Current.Hash, (InputArgument)96, (InputArgument)false);


                    }
                    else if (Game.Player.Character.Armor > 0 && Game.Player.Character.Weapons.Current.Ammo > 120)
                    {
                        Function.Call<int>(Hash.SET_PED_AMMO, (InputArgument)Game.Player.Character, (InputArgument)Game.Player.Character.Weapons.Current.Hash, (InputArgument)120, (InputArgument)false);

                    }
                }
                else if (!GTAExpansion.InventoryBag.doesPedHasInventoryBag(Game.Player.Character))
                {



                    if (Game.Player.Character.Armor == 0 && Game.Player.Character.Weapons.Current.Ammo > 36)
                    {
                        Function.Call<int>(Hash.SET_PED_AMMO, (InputArgument)Game.Player.Character, (InputArgument)Game.Player.Character.Weapons.Current.Hash, (InputArgument)36, (InputArgument)true);

                    }
                    else if (Game.Player.Character.Armor > 0 && Game.Player.Character.Weapons.Current.Ammo > 72)
                    {
                        Function.Call<int>(Hash.SET_PED_AMMO, (InputArgument)Game.Player.Character, (InputArgument)Game.Player.Character.Weapons.Current.Hash, (InputArgument)72, (InputArgument)true);

                    }
                }
            }
            else if (Game.Player.Character.Weapons.Current.Group == WeaponGroup.SMG)
            {
                if (GTAExpansion.InventoryBag.doesPedHasInventoryBag(Game.Player.Character))
                {
                    if (Game.Player.Character.Armor == 0 && Game.Player.Character.Weapons.Current.Ammo > 280)
                    {

                        Function.Call<int>(Hash.SET_PED_AMMO, (InputArgument)Game.Player.Character, (InputArgument)Game.Player.Character.Weapons.Current.Hash, (InputArgument)280, (InputArgument)true);


                    }
                    else if (Game.Player.Character.Armor > 0 && Game.Player.Character.Weapons.Current.Ammo > 320)
                    {
                        Function.Call<int>(Hash.SET_PED_AMMO, (InputArgument)Game.Player.Character, (InputArgument)Game.Player.Character.Weapons.Current.Hash, (InputArgument)320, (InputArgument)true);

                    }
                }
                else if (!GTAExpansion.InventoryBag.doesPedHasInventoryBag(Game.Player.Character))
                {



                 if (Game.Player.Character.Armor == 0 && Game.Player.Character.Weapons.Current.Ammo > 120)
                    {
                        Function.Call<int>(Hash.SET_PED_AMMO, (InputArgument)Game.Player.Character, (InputArgument)Game.Player.Character.Weapons.Current.Hash, (InputArgument)120, (InputArgument)true);

                    }
                    else if (Game.Player.Character.Armor > 0 && Game.Player.Character.Weapons.Current.Ammo > 210)
                    {
                        Function.Call<int>(Hash.SET_PED_AMMO, (InputArgument)Game.Player.Character, (InputArgument)Game.Player.Character.Weapons.Current.Hash, (InputArgument)210, (InputArgument)true);

                    }
                }
            }

            else if (Game.Player.Character.Weapons.Current.Group == WeaponGroup.Shotgun)
            {
                if (GTAExpansion.InventoryBag.doesPedHasInventoryBag(Game.Player.Character))
                {
                    if (Game.Player.Character.Armor == 0 && Game.Player.Character.Weapons.Current.Ammo > 96 )
                    {

                        Function.Call<int>(Hash.SET_PED_AMMO, (InputArgument)Game.Player.Character, (InputArgument)Game.Player.Character.Weapons.Current.Hash, (InputArgument)96, (InputArgument)true);


                    }
                    else if (Game.Player.Character.Armor > 0 && Game.Player.Character.Weapons.Current.Ammo > 120)
                    {
                        Function.Call<int>(Hash.SET_PED_AMMO, (InputArgument)Game.Player.Character, (InputArgument)Game.Player.Character.Weapons.Current.Hash, (InputArgument)120, (InputArgument)true);

                    }
                }
                else if (!GTAExpansion.InventoryBag.doesPedHasInventoryBag(Game.Player.Character))
                {



                    if (Game.Player.Character.Armor == 0 && Game.Player.Character.Weapons.Current.Ammo > 36)
                    {
                        Function.Call<int>(Hash.SET_PED_AMMO, (InputArgument)Game.Player.Character, (InputArgument)Game.Player.Character.Weapons.Current.Hash, (InputArgument)36, (InputArgument)true);

                    }
                    else if (Game.Player.Character.Armor > 0 && Game.Player.Character.Weapons.Current.Ammo > 50)
                    {
                        Function.Call<int>(Hash.SET_PED_AMMO, (InputArgument)Game.Player.Character, (InputArgument)Game.Player.Character.Weapons.Current.Hash, (InputArgument)50, (InputArgument)true);

                    }
                }

            }
            else if (Game.Player.Character.Weapons.Current.Group == WeaponGroup.MG)
            {
                if (GTAExpansion.InventoryBag.doesPedHasInventoryBag(Game.Player.Character))
                {
                    if (Game.Player.Character.Armor == 0 && Game.Player.Character.Weapons.Current.Ammo > 1000)
                    {

                        Function.Call<int>(Hash.SET_PED_AMMO, (InputArgument)Game.Player.Character, (InputArgument)Game.Player.Character.Weapons.Current.Hash, (InputArgument)1000, (InputArgument)true);


                    }
                    else if (Game.Player.Character.Armor > 0 && Game.Player.Character.Weapons.Current.Ammo > 1500)
                    {
                        Function.Call<int>(Hash.SET_PED_AMMO, (InputArgument)Game.Player.Character, (InputArgument)Game.Player.Character.Weapons.Current.Hash, (InputArgument)1500, (InputArgument)true);

                    }
                }
                else if (!GTAExpansion.InventoryBag.doesPedHasInventoryBag(Game.Player.Character))
                {



                    if (Game.Player.Character.Armor == 0 && Game.Player.Character.Weapons.Current.Ammo > 500)
                    {
                        Function.Call<int>(Hash.SET_PED_AMMO, (InputArgument)Game.Player.Character, (InputArgument)Game.Player.Character.Weapons.Current.Hash, (InputArgument)500, (InputArgument)true);

                    }
                    else if (Game.Player.Character.Armor > 0 && Game.Player.Character.Weapons.Current.Ammo > 1000)
                    {
                        Function.Call<int>(Hash.SET_PED_AMMO, (InputArgument)Game.Player.Character, (InputArgument)Game.Player.Character.Weapons.Current.Hash, (InputArgument)1000, (InputArgument)true);

                    }
                }

            }
            else if (Game.Player.Character.Weapons.Current.Group == WeaponGroup.Thrown)
            {

                if (Game.Player.Character.Armor == 0 && Game.Player.Character.Weapons.Current.Ammo > 5)
                {
                    Function.Call<int>(Hash.SET_PED_AMMO, (InputArgument)Game.Player.Character, (InputArgument)Game.Player.Character.Weapons.Current.Hash, (InputArgument)5, (InputArgument)true);

                }
                else if (Game.Player.Character.Armor > 0 && Game.Player.Character.Weapons.Current.Ammo > 10)
                {
                    Function.Call<int>(Hash.SET_PED_AMMO, (InputArgument)Game.Player.Character, (InputArgument)Game.Player.Character.Weapons.Current.Hash, (InputArgument)10, (InputArgument)true);

                }


            }
            else if (Game.Player.Character.Weapons.Current.Group == WeaponGroup.Sniper)
            {
                if (GTAExpansion.InventoryBag.doesPedHasInventoryBag(Game.Player.Character))
                {
                    if (Game.Player.Character.Armor == 0 && Game.Player.Character.Weapons.Current.Ammo > 60)
                    {

                        Function.Call<int>(Hash.SET_PED_AMMO, (InputArgument)Game.Player.Character, (InputArgument)Game.Player.Character.Weapons.Current.Hash, (InputArgument)60, (InputArgument)true);


                    }
                    else if (Game.Player.Character.Armor > 0 && Game.Player.Character.Weapons.Current.Ammo > 90)
                    {
                        Function.Call<int>(Hash.SET_PED_AMMO, (InputArgument)Game.Player.Character, (InputArgument)Game.Player.Character.Weapons.Current.Hash, (InputArgument)90, (InputArgument)true);

                    }
                }
                else if (Game.Player.Character.Armor == 0 && Game.Player.Character.Weapons.Current.Ammo > 21 && !GTAExpansion.InventoryBag.doesPedHasInventoryBag(Game.Player.Character))
                {
                    Function.Call<int>(Hash.SET_PED_AMMO, (InputArgument)Game.Player.Character, (InputArgument)Game.Player.Character.Weapons.Current.Hash, (InputArgument)21, (InputArgument)true);

                }
                else if (Game.Player.Character.Armor > 0 && Game.Player.Character.Weapons.Current.Ammo > 50)
                {
                    Function.Call<int>(Hash.SET_PED_AMMO, (InputArgument)Game.Player.Character, (InputArgument)Game.Player.Character.Weapons.Current.Hash, (InputArgument)50, (InputArgument)true);

                }


            }







        }
    }


}
