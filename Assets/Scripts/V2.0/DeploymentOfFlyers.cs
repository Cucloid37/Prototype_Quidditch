namespace V2._0
{
    public class DeploymentOfFlyers
    {
        private FieldPresenter _field;
        private ProfilePlayer _profile;
        
        public DeploymentOfFlyers(FieldPresenter field, ProfilePlayer profile)
        {
            _field = field;
            _profile = profile;
            Deployment();
        }

        public void Deployment()
        {
            _profile.TeamOne.Value[0].SetCoor(_field.Models[10].MyCoordinates);
            _profile.TeamOne.Value[1].SetCoor(_field.Models[20].MyCoordinates);
            _profile.TeamOne.Value[2].SetCoor(_field.Models[30].MyCoordinates);
            _profile.TeamOne.Value[3].SetCoor(_field.Models[40].MyCoordinates);
            _profile.TeamOne.Value[4].SetCoor(_field.Models[50].MyCoordinates);
            _profile.TeamOne.Value[5].SetCoor(_field.Models[60].MyCoordinates);
            _profile.TeamOne.Value[6].SetCoor(_field.Models[70].MyCoordinates);
            
            _profile.TeamTwo.Value[0].SetCoor(_field.Models[110].MyCoordinates);
            _profile.TeamTwo.Value[1].SetCoor(_field.Models[120].MyCoordinates);
            _profile.TeamTwo.Value[2].SetCoor(_field.Models[130].MyCoordinates);
            _profile.TeamTwo.Value[3].SetCoor(_field.Models[140].MyCoordinates);
            _profile.TeamTwo.Value[4].SetCoor(_field.Models[150].MyCoordinates);
            _profile.TeamTwo.Value[5].SetCoor(_field.Models[160].MyCoordinates);
            _profile.TeamTwo.Value[6].SetCoor(_field.Models[170].MyCoordinates);


        }
    }
}