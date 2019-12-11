var config = {
    type: Phaser.AUTO,
    width: 1400,
    height: 600,
    physics: {
        default: 'arcade',
        arcade: {
            gravity: { y: 200 },
            debug: false
        }
    },
    scene: {
        preload: preload,
        create: create,
        update: update
    }
};

var player;
var platforms;
var cursors;
var previousKey;
var game = new Phaser.Game(config);

function preload ()
{
    this.load.image('sky', 'assets/sky.png');
    this.load.image('boba', 'assets/bobafeet.png');
}

function create ()
{
    this.add.image(400, 300, 'sky');

    platforms = this.physics.add.staticGroup();

    player = this.physics.add.sprite(100, 450, 'boba');

    player.setBounce(0.2);

    cursors = this.input.keyboard.createCursorKeys();

}

function update ()
{

    if (cursors.left.isDown)
    {
        player.setVelocityX(-160);
    }
    else if (cursors.right.isDown)
    {
        player.setVelocityX(160);
    }
    else
    {
        player.setVelocityX(0);
    }

    if (cursors.up.isDown && !previousKey)
    {
        player.setVelocityY(-200);
    }

    previousKey = cursors.up.isDown;
}