document.getElementById('cadastro_2_form').addEventListener('submit', function(event) {
    event.preventDefault();

    // Obtém os valores dos campos do formulário
    const nome = document.getElementById('cadastro_2_nome').value;
    const email = document.getElementById('cadastro_2_email').value;
    const senha = document.getElementById('cadastro_2_password').value;
    const confirmaSenha = document.getElementById('cadastro_2_confirm').value;

    // Cria um objeto com os dados do formulário
    const data = {
        nomeCompleto: nome,
        Email: email,
        Senha: senha,
        ConfirmaSenha: confirmaSenha
    };

    // Faz a chamada à API
    fetch('http://localhost:5059/UserPaciente', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(data)
    })
});