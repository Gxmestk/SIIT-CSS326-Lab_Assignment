<?php
session_start();


// Initialize game state or load from session
if (!isset($_SESSION['game_state'])) {
    $_SESSION['game_state'] = [
        'player_position' => [0, 0], // Initial position [row, column]
    ];
}

// Check for user actions
if (isset($_GET['action'])) {
    switch ($_GET['action']) {
        case 'move_up':
            $_SESSION['game_state']['player_position'][0]--;
            break;
        case 'move_down':
            $_SESSION['game_state']['player_position'][0]++;
            break;
        case 'move_left':
            $_SESSION['game_state']['player_position'][1]--;
            break;
        case 'move_right':
            $_SESSION['game_state']['player_position'][1]++;
            break;
        // Add more actions here as needed
    }
}

// Display game state
echo '<h2>Player Position: (' . $_SESSION['game_state']['player_position'][0] . ', ' . $_SESSION['game_state']['player_position'][1] . ')</h2>';

?>