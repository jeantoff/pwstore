/*    
    PWSTORE store login informations fin an encrypted xml file
    Use only for testing or code re-use purpose.
    
    Copyright (C) 2014  Jean-Christophe Bouvard

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.

    Also add information on how to contact you by electronic and paper mail.

If the program does terminal interaction, make it output a short notice like this when it starts in an interactive mode:

    PWSTORE  Copyright (C) 2014  Jean-Christophe Bouvard
    This program comes with ABSOLUTELY NO WARRANTY.
    This is free software, and you are welcome to redistribute it
    under certain conditions.
*/
namespace pwstore {
    
    
    // Cette classe vous permet de gérer des événements spécifiques dans la classe de paramètres :
    //  L'événement SettingChanging est déclenché avant la modification d'une valeur de paramètre.
    //  L'événement PropertyChanged est déclenché après la modification d'une valeur de paramètre.
    //  L'événement SettingsLoaded est déclenché après le chargement des valeurs de paramètre.
    //  L'événement SettingsSaving est déclenché avant l'enregistrement des valeurs de paramètre.
    internal sealed partial class Settings1 {
        
        public Settings1() {
            // // Pour ajouter des gestionnaires d'événements afin d'enregistrer et de modifier les paramètres, supprimez les marques de commentaire des lignes ci-dessous :
            //
            // this.SettingChanging += this.SettingChangingEventHandler;
            //
            // this.SettingsSaving += this.SettingsSavingEventHandler;
            //
        }
        
        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e) {
            // Ajouter du code pour gérer l'événement SettingChangingEvent ici.
        }
        
        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e) {
            // Ajouter du code pour gérer l'événement SettingsSaving ici.
        }
    }
}
