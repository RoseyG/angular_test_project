using Microsoft.AspNetCore.Mvc;

namespace angular_test_project.Controllers;

[ApiController]
[Route("[controller]")]
public class SceneController : ControllerBase
{
    private static readonly string[] scenes = new[]
    {
        "Cupcake ipsum dolor sit amet liquorice tiramisu liquorice. Shortbread jujubes candy canes tart pie cake caramels. Candy canes apple pie wafer bear claw soufflé fruitcake lemon drops. Donut muffin tart caramels carrot cake.",
        "Soufflé dessert topping sweet roll chocolate cake cookie gingerbread. Danish lemon drops chupa chups toffee bonbon sugar plum ice cream bonbon. Jujubes gummi bears jujubes cake danish tiramisu dragée sugar plum. Caramels carrot cake cheesecake bonbon jelly-o. Sweet roll chupa chups chocolate powder soufflé. Tootsie roll lemon drops gummies gingerbread lemon drops oat cake chocolate. Sweet roll gummies jelly beans sweet marzipan. Marshmallow ice cream shortbread brownie cake chocolate bar cake wafer lemon drops. Danish toffee tart jelly icing. Lemon drops liquorice powder ice cream dessert. Pudding donut cake marshmallow gingerbread powder cookie pudding. Carrot cake sesame snaps dessert soufflé macaroon cake liquorice.",
        "Tootsie roll jelly tiramisu sugar plum donut muffin wafer muffin toffee. Tiramisu chocolate cake toffee jelly beans chocolate cake tart biscuit tiramisu dragée. Donut halvah muffin chocolate bar gummi bears cotton candy chocolate cake.",
        "I love brownie toffee chocolate bar icing cake muffin pastry. Toffee danish halvah I love sesame snaps chocolate bar. Powder croissant cake chocolate cake cheesecake. Icing gingerbread fruitcake pudding gummies gummies I love chocolate. Macaroon macaroon carrot cake I love marshmallow. Marshmallow cookie halvah wafer cake. Lemon drops I love marzipan croissant jujubes I love pudding croissant apple pie.",
        "Bonbon lollipop chocolate bar gingerbread candy ice cream jelly beans. Gummi bears liquorice cupcake gummies bonbon croissant. Tiramisu jelly beans pudding brownie pudding chocolate candy canes cheesecake. Gummi bears icing chocolate ice cream sugar plum oat cake soufflé wafer."
    };

    private readonly ILogger<SceneController> _logger;
    
    public SceneController(ILogger<SceneController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public Scene Get()
    {
        int index = Random.Shared.Next(scenes.Length);
        return new Scene
        {
            sceneId = index,
            sceneText = scenes[index]
        };
    }
}
