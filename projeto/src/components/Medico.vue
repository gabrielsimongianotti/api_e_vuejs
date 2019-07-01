<template>
  <div id="paciente">
    <div id ="add">
      <a href="#/CadastroMedico"><img src="../assets/add.png"></a> 
    </div>
    <card crm="1000" nome="João"/>
    <card crm="1001" nome="Ze"/>
    <card crm="1002" nome="Mario"/>
    <card crm="1003" nome="Maria"/>
    <card crm="1004" nome="Vinicios"/>
  </div>
</template>

<script>
  import card from './CardMedico.vue'

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
