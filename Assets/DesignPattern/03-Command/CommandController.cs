using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CommandController : MonoBehaviour
{
    private Queue<Command> commands = new Queue<Command>();
    [SerializeField]private Command currCommand;

    private void Update()
    {
        ListenforCommands();
        ProccesCommand();
    }
    private void ListenforCommands()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray , out var infoHit))
            {
                MoveCommand move = new MoveCommand(infoHit.point, transform);
                commands.Enqueue(move);
            }
        }
    }
    private void ProccesCommand()
    {
        if (currCommand != null && !currCommand.isEnd)
        {
            print(":|01");
            return;
        }
        if (!commands.Any())
        {
            print(":|02");
            return;
        }
        currCommand = commands.Dequeue();
        currCommand.Exe();

    }
 
}
internal class MoveCommand : Command
{
    private readonly Vector3 distanation;
    private readonly Transform character;

    public MoveCommand(Vector3 dis , Transform chara)
    {
        this.distanation = dis;
        this.character = chara;
    }
    public override bool isEnd => (Vector3.Distance(character.position , distanation)) < 0.1f;

    public override void Exe()
    {
        character.position = Vector3.Lerp(character.position, distanation, 2f);
    }
}
