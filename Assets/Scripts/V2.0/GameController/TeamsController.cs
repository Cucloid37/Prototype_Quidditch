using System.Collections.Generic;
using V2._0.Predicates;

namespace V2._0
{
    public class TeamsController
    {
        private FlyersInitialization _teams;

        //todo ведёт проверку на предикаты и контроллирует последовательность ходов

        private IPredicate[] IsMyMove;
        private int _countMove;

        //todo вынести в сборник констант
        private const int FIRST = 0;  
        
        public TeamsController(FlyersInitialization initialization)
        {
            _teams = initialization;
        }

            //todo откуда передаётся контекст - и что он из себя представляет? Событие?
         // Судя по всему, реально событие, которое передаёт измененные данные. 
        // Или я не так понял? Прочитать про предикаты. Пересмотреть видео. Чекнуть в предыдущем курсе
        public void ChangeTeam(IContext context)
        {
            
            for (int i = 0; i < _teams.TeamOne.Capacity; i++)
            {
                for (int j = 0; j < _teams.TeamOne[FIRST].СanIFly.Length; j++)
                {
                    _teams.TeamOne[i].СanIFly[j].IsReady(context);
                }
                    
            }
            
        }
    }
}