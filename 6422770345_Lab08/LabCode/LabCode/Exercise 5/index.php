<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>PHP RPG Game</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <div class="game-container">
        <?php
            require_once 'game.php';
        ?>

        <div class="grid-container">
            <?php
                // Generate a 5x5 grid
                for ($row = 0; $row < 5; $row++) {
                    for ($col = 0; $col < 5; $col++) {
                        $classes = 'grid-item';
                        if ($row == $_SESSION['game_state']['player_position'][0] && $col == $_SESSION['game_state']['player_position'][1]) {
                            $classes .= ' player';
                        }
                        echo '<div class="' . $classes . '"></div>';
                    }
                }
            ?>
        </div>

        <a href="?action=move_up">Move Up</a>
        <a href="?action=move_down">Move Down</a>
        <a href="?action=move_left">Move Left</a>
        <a href="?action=move_right">Move Right</a>
    </div>
</body>
</html>