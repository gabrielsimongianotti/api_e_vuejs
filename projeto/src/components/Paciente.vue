<template>
  <div id="paciente">
    <div id ="add">
      <a href="#/CadastroPaciente"><img src="../assets/add.png"></a> 
    </div>
    <card cartao="1000" nome="João" dtNascimento="20/07/2000"/>
    <card cartao="1001" nome="Ze" dtNascimento="19/09/1990"/>
    <card cartao="1002" nome="Mario" dtNascimento="10/11/1996"/>
    <card cartao="1003" nome="Maria" dtNascimento="01/04/1999"/>
    <card cartao="1004" nome="Vinicios" dtNascimento="02/02/1998"/>
  </div>
</template>

<script>
  import card from './CardPaciente.vue'

  export default {
    name: 'paciente',
    components: {
      card
    }
  }
</script>

<style>
#add{
  text-align: right;
  margin: -30px 2% 0% 0%;
  position: relative;
}
</style>
