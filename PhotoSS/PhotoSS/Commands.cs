using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace PhotoSS
{
    abstract class Commands : ICommand
    {
        public LocationViewModel LocationVM;
        public Commands(LocationViewModel lvm)
        {
            LocationVM = lvm;
        }
        
        public PeopleViewModel PeopleVM;
        public Commands(PeopleViewModel pvm)
        {
            PeopleVM = pvm;
        }
        
        public PhotoViewModel PhotoVM;
        public Commands(PhotoViewModel phvm)
        {
            PhotoVM = phvm;
        }
        
        public event EventHandler CanExecuteChanged;
        public abstract bool CanExecute(object p);
        public abstract void Execute(object p);

    }

    ////////LOCATIONS//////////
    class AddLocationCommand : Commands
    {
        public AddLocationCommand(LocationViewModel location) : base(location)
        { }
        public override bool CanExecute(object p)
        { return true; }
        public override void Execute(object p)
        {
            int n = 1;
            if (LocationVM.Locations.Count > 0)
            {
                n = LocationVM.Locations.Max(t => t.Id) + 1;
            }
            var l = p as LocationViewModel;

            if (!LocationVM.Locations.Contains(l.Selected))
            {
                LocationVM.Locations.Add(l.Selected);
            }
            LocationVM.Selected = l.Selected;  //Navigate to Page

        }
    }
    class DeleteLocationCommand : Commands
    {
        public DeleteLocationCommand(LocationViewModel location) : base(location)
        { }
        public override bool CanExecute(object p)
        { return true; }
        public override void Execute(object p)
        {
            LocationVM.Locations.Remove(LocationVM.Selected);
            LocationVM.Selected = new Location(); 
        }
    }

    //////////PEOPLE///////////
    class AddPersonCommand : Commands
    {
        public AddPersonCommand(PeopleViewModel person) : base(person)
        { }
        public override bool CanExecute(object p)
        { return true; }
        public override void Execute(object p)
        {
            int n = 1;
            if (PeopleVM.People.Count > 0)
            {
                n = PeopleVM.People.Max(t => t.Id) + 1;
            }
            var l = p as PeopleViewModel;

            if (!PeopleVM.People.Contains(l.Selected))
            {
                PeopleVM.People.Add(l.Selected);
            }
            PeopleVM.Selected = l.Selected;  //Navigate to Page

        }
    }

    ////////PHOTOSHOOTS//////////
    class AddPhotoCommand : Commands
    {
        public AddPhotoCommand(PhotoViewModel photo) : base(photo)
        { }
        public override bool CanExecute(object p)
        { return true; }
        public override void Execute(object p)
        {
            int n = 1;
            if (PhotoVM.Photoshoots.Count > 0)
            {
                n = PhotoVM.Photoshoots.Max(t => t.Id) + 1;
            }
            var l = p as PhotoViewModel;

            if (!PhotoVM.Photoshoots.Contains(l.Selected))
            {
                PhotoVM.Photoshoots.Add(l.Selected);
            }
            PhotoVM.Selected = l.Selected;  //Navigate to Page

        }
    }
    class DeletePhotoCommand : Commands
    {
        public DeletePhotoCommand(PhotoViewModel photo) : base(photo)
        { }
        public override bool CanExecute(object p)
        { return true; }
        public override void Execute(object p)
        {
            PhotoVM.Photoshoots.Remove(PhotoVM.Selected);
            PhotoVM.Selected = new Photoshoot();
        }
    }

}

