CREATE SCHEMA PRN3S2B123RRP;
USE PRN3S2B123RRP;
-- -----------------------------------------------------
-- Table `PRN3S2B123RRP`.`TbPacientesRRP`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `PRN3S2B123RRP`.`TbPacientesRRP` (
  `idPacientes` INT NOT NULL AUTO_INCREMENT,
  `Nombre` VARCHAR(100) NOT NULL,
  `ApellidoPaterno` VARCHAR(100) NOT NULL,
  `ApellidoMaterno` VARCHAR(100) NOT NULL,
  `Direccion` VARCHAR(45) NOT NULL,
  `Celular` VARCHAR(10) NOT NULL,
  `TelefonoFijo` VARCHAR(10) NOT NULL,
  `Edad` INT NOT NULL,
  `Sexo` CHAR(1) NOT NULL,
  `Email` VARCHAR(50) NOT NULL,
  `EstadoCivil` INT NOT NULL,
  PRIMARY KEY (`idPacientes`))
ENGINE = InnoDB;
-- -----------------------------------------------------
-- Table `PRN3S2B123RRP`.`TbEspecialidadesRRP`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `PRN3S2B123RRP`.`TbEspecialidadesRRP` (
  `idEspecialidades` INT NOT NULL AUTO_INCREMENT,
  `Nombre` VARCHAR(45) NOT NULL,
  `Descripcion` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`idEspecialidades`))
ENGINE = InnoDB;
-- -----------------------------------------------------
-- Table `PRN3S2B123RRP`.`TbMedicosRRP`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `PRN3S2B123RRP`.`TbMedicosRRP` (
  `idMedicos` INT NOT NULL AUTO_INCREMENT,
  `Nombre` VARCHAR(45) NOT NULL,
  `ApellidoPaterno` VARCHAR(45) NOT NULL,
  `ApellidoMaterno` VARCHAR(45) NOT NULL,
  `Cedula` VARCHAR(15) NOT NULL,
  `idEspecialidades` INT NOT NULL,
  PRIMARY KEY (`idMedicos`),
  INDEX `fx_medico_especialidad_idx` (`idEspecialidades` ASC) VISIBLE,
  CONSTRAINT `fk_medico_especialidad`
    FOREIGN KEY (`idEspecialidades`)
    REFERENCES `PRN3S2B123RRP`.`TbEspecialidadesRRP` (`idEspecialidades`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;
-- -----------------------------------------------------
-- Table `PRN3S2B123RRP`.`TbPacientesMedicosRRP`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `PRN3S2B123RRP`.`TbPacientesMedicosRRP` (
  `idPacientes` INT NOT NULL,
  `idMedicos` INT NOT NULL,
  INDEX `fk_medico_paciente_idx` (`idMedicos` ASC) INVISIBLE,
  INDEX `fk_paciente_medico_idx` (`idPacientes` ASC) VISIBLE,
  CONSTRAINT `fk_pacientes`
    FOREIGN KEY (`idPacientes`)
    REFERENCES `PRN3S2B123RRP`.`TbPacientesRRP` (`idPacientes`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_medicos`
    FOREIGN KEY (`idMedicos`)
    REFERENCES `PRN3S2B123RRP`.`TbMedicosRRP` (`idMedicos`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- Insertar datos de especialidades
INSERT INTO tbespecialidadesrrp (Nombre, Descripcion) VALUES
    ('Cardiología', 'Especialidad en enfermedades cardíacas y vasculares.'),
    ('Dermatología', 'Especialidad en enfermedades de la piel, cabello y uñas.'),
    ('Neurología', 'Especialidad en enfermedades neurológicas y del sistema nervioso.'),
    ('Ginecología', 'Especialidad en salud reproductiva de las mujeres.'),
    ('Oftalmología', 'Especialidad en salud ocular y problemas de la vista.'),
    ('Oncología', 'Especialidad en diagnóstico y tratamiento del cáncer.');

-- Insertar datos de médicos
INSERT INTO tbmedicosrrp (Nombre, ApellidoPaterno, ApellidoMaterno, Cedula, idEspecialidades) VALUES ('Juan', 'Pérez', 'López', '12345','1'),
	('María', 'Lopéz', 'Ramos', '67890','2'),
    ('Luisa', 'Sanchez', 'Hernandez', '12346','3'),
    ('Raúl', 'Ramírez', 'Pérez', '66789','4'),
    ('Julia', 'Mercado', 'Jimenez', '12347','5'),
    ('Pedro', 'Montiel', 'Blanco', '67890','6'),
    ('Gabriel', 'Alcala', 'Rodriguez', '12348','1'),
    ('Karla', 'Montiel', 'Ramos', '68890','2');
